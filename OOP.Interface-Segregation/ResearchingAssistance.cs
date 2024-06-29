using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interface_Segregation
{
    public class ResearchingAssistance : IResearchingAssistance
    {
        public void Lecturing()
        {
            throw new NotImplementedException();
        }

        public void Researching()
        {
            throw new NotImplementedException();
        }
    }
}
