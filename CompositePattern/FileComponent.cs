namespace CompositePattern
{
    public abstract class FileComponent
    {
        private string name;
        public abstract void Add(FileComponent component);
        public abstract void Remove(FileComponent component);
        public abstract FileComponent GetChild(int i);
        public abstract bool Operation(int depth);

        public FileComponent(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
    }
}
