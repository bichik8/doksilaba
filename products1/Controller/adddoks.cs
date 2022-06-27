using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using products1.Model;

namespace products1.Controller
{
    internal class adddoks
    {
        public List<Infodok> Bichmoki { get; set; }
        private string _path;
        public adddoks(string path)
        {
            _path = path;
              Bichmoki = gDoks();
        }
        public void file()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                using (FileStream fs = new FileStream(_path, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, Bichmoki);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private List<Infodok> gDoks()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                using (FileStream fs = new FileStream(_path, FileMode.OpenOrCreate))
                {
                    List<Infodok> rec = formatter.Deserialize(fs) as List<Infodok>;
                    fs.Close();
                    if (rec != null)
                        return rec;
                    else
                        return new List<Infodok>();
                }
            }
            catch (SerializationException)
            {
                return new List<Infodok>();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Add(string doki, string colvo, string typi)
        {
            Bichmoki.Add(new Infodok(doki, colvo, typi));
            try
            {
                file();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}