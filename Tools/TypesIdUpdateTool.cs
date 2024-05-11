using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Dtwo.API.DofusBase;

namespace Dtwo.API.Dofus2.Tools
{
	public class TypesIdUpdateTool
	{
		public readonly static string TempPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "temp", "TypesIdUpdateTool");
        public static void Parse(Action<bool> resultAction) => Task.Factory.StartNew(() =>
        {
            InternalParse(resultAction);
        }, TaskCreationOptions.LongRunning);

        private static void InternalParse(Action<bool> resultAction)
		{
			List<DofusTypeBinding> bindings = new List<DofusTypeBinding>();

			ExportSwf((result) =>
			{
				ForeachDirectoriesRecursive(TempPath, (files) =>
				{
					ParseFiles(files, ref bindings);
				});

				try
				{
					string txt = Newtonsoft.Json.JsonConvert.SerializeObject(bindings);
					File.WriteAllText(Dtwo.API.Paths.Dofus2BindingTypesPath, txt);
				}
				catch (Exception ex)
				{
					resultAction?.Invoke(false);
				}

				resultAction?.Invoke(true);
			});


		}

		private static void ExportSwf(Action<int> onFinishAction)
		{
			if (Directory.Exists(TempPath))
			{
				Directory.Delete(TempPath, true);
			}

			Directory.CreateDirectory(TempPath);

			ParseSfw(
               Dtwo.API.Paths.Config.JpexsPath,
               Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Ankama", "Dofus", "DofusInvoker.swf"),
			   TempPath,
			   new string[] {
					"com.ankamagames.dofus.network.types.++"
			   },
			   onFinishAction);
		}

		public static void ParseSfw(string jpexsPath, string swfPath, string writeFolderPath, string[] classNames, Action<int> onFinish)
		{
			ProcessStartInfo startInfo = new ProcessStartInfo();

			string classes = string.Join(",", classNames);
			startInfo.FileName = jpexsPath;

			Process process = new Process()
			{
				StartInfo = startInfo,
				EnableRaisingEvents = true
			};

			process.Exited += (sender, args) =>
			{
				onFinish?.Invoke(process.ExitCode);
			};

            startInfo.Arguments = $"-selectclass {classes} -export script \"{writeFolderPath}\" \"{swfPath}\"";
            process.Start();
		}

		private static void ForeachDirectoriesRecursive(string path, Action<string[]> filesCallback)
		{
			var files = Directory.GetFiles(path, "*.as");
			var directories = Directory.GetDirectories(path);

			filesCallback.Invoke(files);

			if (directories == null)
			{
				return;
			}

			foreach (var d in directories)
			{
				ForeachDirectoriesRecursive(d, filesCallback);
			}
		}

		private static void ParseFiles(string[] paths, ref List<DofusTypeBinding> bindings)
		{
			foreach (var p in paths)
			{
				var binding = ParseFile(p);

				if (binding == null) continue;

				bindings.Add(binding);
			}
		}

		private static DofusTypeBinding ParseFile(string path)
		{
			using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
			{
				using (StreamReader sr = new StreamReader(fs))
				{
					string line = "";
					string protocolId = null;
					string className = null;
					while ((line = sr.ReadLine()) != null)
					{
						if (protocolId != null && className != null)
						{
							return new DofusTypeBinding()
							{
								Identifier = protocolId,
								ClassName = className
							};
						}

						if (line == null)
						{
							continue;
						}

						if (line.Contains("protocolId:uint"))
						{
							Match match = Regex.Match(line, @"\s*public\s+static\s+const\s+protocolId:\s*uint\s*=\s*(\d+);\s*");

							if (match.Success == false)
							{
								return null;
							}

							protocolId = match.Groups[1].Value;
						}
						else if (line.Contains("public class"))
						{
							Match match = Regex.Match(line, @"\s*public\s+class\s+(\w+)\s+");
							className = match.Groups[1].Value;
						}
					}
				}
			}

			return null;
		}
	}
}
