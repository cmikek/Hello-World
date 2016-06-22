using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.Interfaces;

namespace HelloWorld.WebAPI.ServiceLayer
{
    public class MessageService : IMessage
    {
        #region Properties

        public string Text { get; set; }

        #endregion

        #region Methods

        public IMessage GetMessage()
        {
            IMessage message = new MessageService()
            {
                Text = "Hello World"
            };

            return message;
        }

        #endregion
    }
}
