using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw22._01c_sharp
{
    public class SampleRepository : IRepository<SampleClass>
    {
        private List<SampleClass> items = new List<SampleClass>();

        public void Add(SampleClass item)
        {
            items.Add(item);
        }

        public void Delete(SampleClass item)
        {
            items.Remove(item);
        }

        public SampleClass GetById(int id)
        {
            return items.FirstOrDefault(item => item.Id == id);
        }
    }

}
