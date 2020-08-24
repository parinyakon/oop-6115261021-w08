using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261021_w08
{
    class ImageData
    {
        private string imageDataName;
        private string imageDataDate;
        private string imageDataType;
        private string imageDataSize;
        public string ImageDataName
        {
            get { return imageDataName; }
            set { this.imageDataName = value; }
        }
        public string ImageDataDate
        {
            get { return imageDataDate; }
            set { this.imageDataDate = value; }
        }
        public string ImageDataType
        {
            get { return imageDataType; }
            set { this.imageDataType = value; }
        }
        public string ImageDataSize
        {
            get { return imageDataSize; }
            set { this.imageDataSize = value; }
        }

        public ImageData() { }
        public ImageData(string idn, string idd, string idt, string ids)
        {
            this.ImageDataName = idn;
            this.ImageDataDate = idd;
            this.ImageDataType = idt;
            this.ImageDataSize = ids;
        }
        public override string ToString()
        {
            return this.ImageDataName + " " + this.ImageDataType;

        }
    }
}
