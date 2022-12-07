using Common;
using System.Text.RegularExpressions;

namespace Day7
{
	internal class Crawler
	{
		private static readonly Regex _DirectoryRegex = new Regex(@"dir (?<name>[a-z]+)");
		private static readonly Regex _FileRegex = new Regex(@"(?<size>[0-9]+) (?<name>[a-z.]+)");

		private const string _RegexGroupName = "name";
		private const string _RegexGroupSize = "size";

		public Folder CurrentFolder { get; set; }

		public Folder BaseFolder => _baseFolder;

		private readonly IList<Folder> _history;
		private readonly Folder _baseFolder = new Folder("___");


		public Crawler()
		{
			_history = new List<Folder>();
			CurrentFolder = _baseFolder;
		}

		public void NavigateFolder(string folderCommand)
		{
			if (folderCommand == "/")
			{
				_history.Clear();
				CurrentFolder = _baseFolder;
				return;
			}

			if (folderCommand == "..")
			{
				CurrentFolder = _history.RemoveLast();
				return;
			}

			_history.Add(CurrentFolder);

			CurrentFolder = (Folder) CurrentFolder.Contents.First(f => f.Name.Equals(folderCommand));
		}

		public void AddListToCurrentFolder(string[] contents)
		{
			foreach(var content in contents)
			{
				if (_DirectoryRegex.IsMatch(content))
				{
					var m = _DirectoryRegex.Match(content);

					CurrentFolder.Add(new Folder(m.Groups[_RegexGroupName].Value));
				}
				else
				{
					var m = _FileRegex.Match(content);

					CurrentFolder.Add(new File(m.Groups[_RegexGroupName].Value, int.Parse(m.Groups[_RegexGroupSize].Value)));
				}
			}
		}

		public IList<Folder> GetAllFolders()
		{
			return _baseFolder.GetAllSubFolders();
		}
	}
}
