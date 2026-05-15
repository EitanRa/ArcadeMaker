using ArcadeMaker.IDE.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcadeMaker.IDE
{
    public class ProjectTreeStruct<T> where T : GameItem
    {
        
    }

    public class ProjectItemTreeStruct<T> : ProjectTreeStruct<T> where T : GameItem
    {
        public GameItem Item;
        public ProjectItemTreeStruct(GameItem item)
        {
            this.Item = item;
        }
    }

    public class ProjectFolderTreeStruct<T> : ProjectTreeStruct<T> where T : GameItem
    {
        public readonly List<ProjectTreeStruct<T>> Structs = new List<ProjectTreeStruct<T>>();

        public string Name = null;
        public bool IsBaseFolder = false;
        public ProjectFolderTreeStruct(string name, bool isBaseFolder)
        {
            this.Name = name;
            this.IsBaseFolder = isBaseFolder;
        }

        public ProjectFolderTreeStruct(string name, bool isBaseFolder, object[] structs) : this(name, isBaseFolder)
        {
            foreach (object obj in structs)
            {
                if (obj is ProjectTreeStruct<T> @struct)
                    this.Structs.Add(@struct);
            }
        }
    }
}
