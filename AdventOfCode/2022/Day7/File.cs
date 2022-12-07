namespace Day7
{
	internal class File : IFileOrFolder
	{
		public int Size { get; }

		public string Name { get; }


		public File(string name, int size)
		{
			Name = name;
			Size = size;
		}
	}
}