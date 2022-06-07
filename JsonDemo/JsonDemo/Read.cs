﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDemo
{
    public class Read
    {
        public TypesOfInventary ReadTheData(string Path)

        {
            using (StreamReader file = new StreamReader(Path))
            {
                try
                {
                    string json = file.ReadToEnd();

                    return JsonConvert.DeserializeObject<TypesOfInventary>(json);
                }
                catch (Exception e)
                {
                    return null;
                }


            }
        }
    }

}