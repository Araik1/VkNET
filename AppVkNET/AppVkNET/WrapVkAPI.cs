using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VkNet;
using VkNet.Enums.Filters;
using VkNet.Model;

namespace AppVkNET
{
    class WrapVkAPI
    {
        private VkApi api;
        private int IDApp;

        public WrapVkAPI()
        {

        }

        public int IDApp1
        {
            get => IDApp;
            set => IDApp = value;
        }
    }
}
