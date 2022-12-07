namespace Day7
{
	internal class Folder : IFileOrFolder
	{
		public int Size => Contents.Select(f => f.Size).Sum();

		public string Name { get; }

		public IReadOnlyList<IFileOrFolder> Contents => _contents.AsReadOnly();


		private readonly IList<IFileOrFolder> _contents;
		
		public Folder(string name)
		{
			Name = name;
			_contents = new List<IFileOrFolder>();
		}

		public void Add(IFileOrFolder fileOrfolder)
		{
			_contents.Add(fileOrfolder);
		}

		public IList<Folder> GetAllSubFolders(bool ignoreSelf = true)
		{
			var result = new List<Folder>();

			if (!ignoreSelf)
			{
				result.Add(this);
			}

			foreach(var folder in _contents)
			{
				if (folder is not Folder)
				{
					continue;
				}

				result.AddRange(((Folder)folder).GetAllSubFolders(false));
			}

			return result;
		}
	}
}
