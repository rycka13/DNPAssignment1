using System.Collections;
using System.Collections.Generic;
using FileData;
using Models;

namespace DNP_assignment_1.Data
{
    public interface IAdultActions
    {
        IList<Adult> getAllAdults();
        void addAdult(Adult adult);
        void removeAdult(Adult adult);
        void editAdult(Adult adult);
        Adult GetAdultById(int id);
        
        IList<Adult> Sort(IList<Adult> adults);


    }
}