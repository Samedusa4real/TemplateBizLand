using System.Collections.Generic;
using TemplateBizLand.Models;

namespace TemplateBizLand.ViewModel
{
    public class HomeViewModel
    {
        public List<Features> features = new List<Features>();
        public List<TeamMembers> teamMembers = new List<TeamMembers>();
        public List<Pricing> pricing = new List<Pricing>();
    }
}
