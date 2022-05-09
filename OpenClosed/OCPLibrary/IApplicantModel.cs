using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibrary
{
    public interface IApplicantModel
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        public IAccounts AccountProcessor { get; set; }
    }
}
