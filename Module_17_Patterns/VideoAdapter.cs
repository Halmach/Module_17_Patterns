using System;
using System.Collections.Generic;
using System.Text;

namespace Module_17_Patterns
{
    class VideoAdapter
    {
        public string Text { get; set; }
        public IHdmiInterface HdmiInterface { get; set; }

        public VideoAdapter(IHdmiInterface hdmiInterface)
        {
            HdmiInterface = hdmiInterface;
        }

        public void Display()
        {
            HdmiInterface.Display(Text);
        }
    }
}
