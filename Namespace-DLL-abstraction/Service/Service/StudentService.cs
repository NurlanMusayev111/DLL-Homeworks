using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class StudentService
    {
        private Student[] GetAll()
        {
            return new Student[]
            {
                new Student {Id=1,FullName = "Nurlan Musayev" , Age = 21 , Email = "nurlan@code.az"},
                new Student {Id=1,FullName = "Rufet Nesibov" , Age = 23 , Email = "rufat@code.az"},
                new Student {Id=1,FullName = "Ramin Mahmudov" , Age = 27 , Email = "ramin@code.az"},
                new Student {Id=1,FullName = "Samil Ferruxov" , Age = 19 , Email = "samil@code.az"},
            };
        }

        public Student[] GetAllStudents()
        {
            return GetAll();
        }


        public Student GetById(int id)
        {
            return GetAll().FirstOrDefault(m => m.Id == id); 
        }

    }
}
