using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading;
using FileData;
using Models;

namespace DNP_assignment_1.Data
{
    public class AdultsManager : IAdultActions
    {
        private FileContext _fileContext;
        private IList<Adult> _adults;

        public AdultsManager()
        {
            _fileContext = new FileContext();
            _adults = Sort(getAllAdults());
            
        }
        public IList<Adult> getAllAdults()
        {
            /*string json = File.ReadAllText("adults.json");
            return JsonSerializer.Deserialize<List<Adult>>(json);*/
            return Sort(_fileContext.Adults);
        }

        public void addAdult(Adult adult)
        {
            //adult.Id = _adults.Max(a => a.Id) + 1;
            int max = _adults.Max(a => a.Id);
            adult.Id = (++max);
            _fileContext.Adults.Add(adult);
            _fileContext.SaveChanges();
        }

        public void removeAdult(Adult adult)
        {
            _fileContext.Adults.Remove(adult);
            _fileContext.SaveChanges();

        }

        /*public void editAdult(Adult adultToRemove, Adult adultToReplace)
        {
            //CAN BE FUCKED
            _fileContext.Adults.Remove(adultToRemove);
            _fileContext.Adults.Insert(_fileContext.Adults.IndexOf(adultToRemove),adultToReplace);
            _fileContext.SaveChanges();
        }*/
        public void editAdult(Adult adult)
        {
            Adult toUpdate = adult;
            /*Adult toUpdate = _adults.First(a => a.Id == adult.Id);
            toUpdate = _adults.First(a => a.Id == adult.Id);
            toUpdate.JobTitle = adult.JobTitle;
            toUpdate.FirstName = adult.FirstName;
            toUpdate.LastName = adult.LastName;
            toUpdate.HairColor = adult.HairColor;
            toUpdate.EyeColor = adult.EyeColor;
            toUpdate.Age = adult.Age;
            toUpdate.Weight = adult.Weight;
            toUpdate.Height = adult.Height;
            toUpdate.Sex = adult.Sex;*/
            _fileContext.Adults.Remove(_adults.First(a => a.Id == adult.Id));
            _fileContext.Adults.Add(toUpdate);
            _fileContext.SaveChanges();

        }

        public Adult GetAdultById(int id)
        {
            return _adults.FirstOrDefault(a => a.Id == id);
        }

        public IList<Adult> Sort(IList<Adult> adults)
        {
            for (int i = 0; i < adults.Count; i++)
            {
                for (int j = 0; j < adults.Count; j++)
                {
                    if (adults[i].Id < adults[j].Id)
                    {
                        (adults[i], adults[j]) = (adults[j], adults[i]);
                    }
                }
            }
            return adults;
        }
    }
}