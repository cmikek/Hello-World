using System;
using HelloWorld.Interfaces;

namespace HelloWorld.WebAPI.Models
{
    public class MessageModel : IMessage
    {
        #region Properties

        public string Text { get; set; }

        #endregion
    }
}
