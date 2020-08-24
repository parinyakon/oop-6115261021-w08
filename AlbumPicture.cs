using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261021_w08
{
    class AlbumPicture
    {
        private string albumPictureCode;
        private string albumPictureName;
        private string albumPictureDate;
        private string albumPictureType;
        private ImageData albumPictureImageData;
        public string AlbumPictureCode
        {
            get { return this.albumPictureCode; }
            set { this.albumPictureCode = value; }
        }
        public string AlbumPictureName
        {
            get { return this.albumPictureName; }
            set { this.albumPictureName = value; }
        }
        public string AlbumPictureDate
        {
            get { return this.albumPictureDate; }
            set { this.albumPictureDate = value; }
        }
        public string AlbumPictureType
        {
            get { return this.albumPictureType; }
            set { this.albumPictureType = value; }
        }
        public ImageData AlbumPictureImageData
        {
            get { return this.albumPictureImageData; }
            set { this.albumPictureImageData = value; }
        }

        public AlbumPicture() { }
        public AlbumPicture(string apc, string apn, string apd, string apt, ImageData apid)
        {
            this.AlbumPictureCode = apc;
            this.AlbumPictureName = apn;
            this.AlbumPictureDate = apd;
            this.AlbumPictureType = apt;
            this.AlbumPictureImageData = apid;
        }
        public override string ToString()
        {
            return this.AlbumPictureCode + " " + this.AlbumPictureName + " " + this.AlbumPictureDate + " " + this.AlbumPictureType + this.AlbumPictureImageData.ToString()
                + " " + this.AlbumPictureImageData.ImageDataDate + " " + this.AlbumPictureImageData.ImageDataSize;


        }
    }
}
