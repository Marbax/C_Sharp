using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace univer
{
    class DataManager
    {
        BinaryFormatter bf = new BinaryFormatter();

        private University _univer;

        public University Univer
        {
            get { return _univer; }
            set { _univer = value; }
        }

        string _fPath;

        public DataManager(University univer = default, string fPath = @"../../univer.dat")
        {
            _univer = univer;
            _fPath = fPath;
        }


        public void SaveData()
        {
            using (FileStream fs = new FileStream(_fPath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
            {
                bf.Serialize(fs, _univer);
            }
            Console.WriteLine("\t\tSave complete");

        }

        public void LoadData()
        {
            using (FileStream fs = new FileStream(_fPath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                _univer = (University)bf.Deserialize(fs);
            }
            Console.WriteLine("\t\tLoad complete");
        }

    }
}
