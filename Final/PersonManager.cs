using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Final
{
    public class SaveLoadPerson : ISaveLoadPerson
    {
        public void SaveListToFile(string _path, List<Person> _people)
        {
            string Data = "";
            foreach (var person in _people)
            {
                Data += Person.PersonToString(person) + "\n";
            }

            File.WriteAllText(_path, Data);
        }

        public List<Person> LoadListFromFile(string _path)
        {
            List<Person> People = new List<Person>();

            //Loading Data ...
            string[] PeopleList = File.ReadAllLines(_path);
            foreach (var item in PeopleList)
            {
                People.Add(Person.StringToPerson(item));
            }

            return People;
        }
    }

    public class SaveLoadPerson_XML : ISaveLoadPerson
    {
        public void SaveListToFile(string Path, List<Person> People)
        {
            FileStream fileStream = new FileStream(Path, FileMode.Create, FileAccess.Write);
            StreamWriter Writer = new StreamWriter(fileStream);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Person>));

            xmlSerializer.Serialize(Writer, People);
            Writer.Close();
        }

        public List<Person> LoadListFromFile(string Path)
        {
            FileStream fileStream = new FileStream(Path, FileMode.Open, FileAccess.Read);
            StreamReader Reader = new StreamReader(fileStream);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Person>));

            var PersonList = (List<Person>)xmlSerializer.Deserialize(Reader);
            Reader.Close();
            return PersonList;
        }
    }

    public class PersonManager
    {
        private readonly string Path;
        private List<Person> PersonList { get; set; }
        private readonly ISaveLoadPerson SaveLoadPerson;

        public PersonManager(string _path, ISaveLoadPerson _saveLoadPerson)
        {
            Path = _path;
            SaveLoadPerson = _saveLoadPerson;
            PersonList = new List<Person>();
            if (!File.Exists(Path))
                File.Create(Path).Close();
            else
                PersonList = SaveLoadPerson.LoadListFromFile(Path);
        }

        public void AddPerson(Person _person)
        {
            PersonList.Add(_person);
            SaveLoadPerson.SaveListToFile(Path, PersonList);
        }

        public void RemovePerson(Person _person)
        {
            PersonList.Remove(_person);
            SaveLoadPerson.SaveListToFile(Path, PersonList);
        }

        public Person SearchPerson(string _national_ID)
        {
            for (int i = 0; i < PersonList.Count; i++)
            {
                if (PersonList[i].National_ID == _national_ID)
                {
                    return PersonList[i];
                }
            }
            return null;
        }
    }
}
