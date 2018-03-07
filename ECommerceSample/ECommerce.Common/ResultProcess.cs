﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Entity;

namespace ECommerce.Common
{
    public class ResultProcess<T>
    {
        public Result<int> GetResult(MyECommerceDBEntities1 db)
        {
            Result<int> result = new Result<int>();
            int sonuc = db.SaveChanges();
            if (sonuc>0)
            {
                result.UserMessage = "Basarili";
                result.IsSuccessed = true;
                result.ProcessResult = sonuc;
            }
            else
            {
                result.UserMessage = "Basarisiz";
                result.IsSuccessed = false;
                result.ProcessResult = sonuc;
            }
            return result;
        }
        public Result<List<T>> GetListResult (List<T> data)
        {
            Result<List<T>> result = new Result<List<T>>();
            if (data != null)
            {
                result.UserMessage = "islem basarili";
                result.IsSuccessed = true;
                result.ProcessResult = data;
            }
            else
            {
                result.UserMessage = "islem basarisiz veri yok";
                result.IsSuccessed = false;
                result.ProcessResult = data;
            }

            return result;

        }
        public Result<T> GetT(T data)
        {
            Result<T> result = new Result<T>();
            if (data != null)
            {
                result.UserMessage = "islem basarili";
                result.IsSuccessed = true;
                result.ProcessResult = data;
            }
            else
            {
                result.UserMessage = "islem basarisiz";
                result.IsSuccessed = false;
                result.ProcessResult = data;
            }
            return result;
        }
    }
}
