using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace StaticData.Data
{
    public class AllData : BaseData
    {
        
		public string obName = "";	//障碍名
		public float obSize = 0;	//障碍尺寸
		
        public override void ReadFromStream(BinaryReader br)
        {
            mID = br.ReadUInt32();	//ID
			obName = br.ReadString();	//障碍名
			obSize = br.ReadSingle();	//障碍尺寸
			
        }
    } 
} 