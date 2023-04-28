using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogwartsProjects_hoseynzadeh
{
    class Dorm
    {
        public int CompletedCapacity = 0;
        // Even Floor = 20 Room Even Room = 4 Bed
        public int DetDorm(Dorm[] Dorms,String Group,bool IsHemale)
        {
            int Gen=1, GroupDorm=1, Floor=1, Room=1, Bed = 1;
            if (IsHemale)
            {
                Gen = 2;
                if (Group == "Gryffindor")
                {
                    GroupDorm = 1;
                }
                if (Group == "Hufflepuff")
                {
                    GroupDorm = 2;
                }
                if (Group == "Ravenclaw")
                {
                    GroupDorm = 3;
                }
                if (Group == "Slytherin")
                {
                    GroupDorm = 4;
                }
            }
            else
            {
                Gen = 1;
                if (Group == "Gryffindor")
                {
                    GroupDorm = 5;
                }
                if (Group == "Hufflepuff")
                {
                    GroupDorm = 6;
                }
                if (Group == "Ravenclaw")
                {
                    GroupDorm = 7;
                }
                if (Group == "Slytherin")
                {
                    GroupDorm = 8;
                }
            }
            Floor = Convert.ToInt32(Dorms[GroupDorm].CompletedCapacity / 20) + 1;
            Room = Convert.ToInt32(Dorms[GroupDorm].CompletedCapacity / 4) + 1;
            Bed = (Dorms[GroupDorm].CompletedCapacity % 4) + 1;
            return (Bed + Room*10 + Floor*100 + GroupDorm*1000 + Gen*10000);
        }
        //
        public int GroupDormForPlus (String Group, bool IsHemale)
        {
            int GroupDorm=0;
            if (IsHemale)
            {
                if (Group == "Gryffindor")
                {
                    GroupDorm = 1;
                }
                if (Group == "Hufflepuff")
                {
                    GroupDorm = 2;
                }
                if (Group == "Ravenclaw")
                {
                    GroupDorm = 3;
                }
                if (Group == "Slytherin")
                {
                    GroupDorm = 4;
                }
            }
            else
            {
                if (Group == "Gryffindor")
                {
                    GroupDorm = 5;
                }
                if (Group == "Hufflepuff")
                {
                    GroupDorm = 6;
                }
                if (Group == "Ravenclaw")
                {
                    GroupDorm = 7;
                }
                if (Group == "Slytherin")
                {
                    GroupDorm = 8;
                }
            }
            return GroupDorm;
        }

    }
}
