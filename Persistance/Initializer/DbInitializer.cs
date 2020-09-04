using Domain.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistance.Initializer
{
    public static class DbInitializer
    {
        public static void Seed(ApplicationDbContext db)
        {
            db.Database.EnsureCreated();
            if (!db.Forms.Any())
            {
                var form = new Form[]
                {
                    new Form{FormId = 1, FormType = "Company"}
                };
                foreach (Form f in form)
                {
                    db.Forms.Add(f);
                }
                db.SaveChanges();
            }

            if (!db.Sections.Any())
            {
                var section = new Section[]
                {
                    new Section{SectionId = 1, SectionName = "Default", IsDefault = true}
                };
                foreach (Section s in section)
                {
                    db.Sections.Add(s);
                }
                db.SaveChanges();
            }
            if (!db.FieldTypes.Any())
            {
                var fieldType = new FieldType[]
                {
                    new FieldType{FieldTypeId = 1, FieldTypeName = "button"},
                    new FieldType{FieldTypeId = 2, FieldTypeName = "checkbox"},
                    new FieldType{FieldTypeId = 3, FieldTypeName = "date"},
                    new FieldType{FieldTypeId = 4, FieldTypeName = "datetime-local"},
                    new FieldType{FieldTypeId = 5, FieldTypeName = "email"},
                    new FieldType{FieldTypeId = 6, FieldTypeName = "file"},
                    new FieldType{FieldTypeId = 7, FieldTypeName = "hidden"},
                    new FieldType{FieldTypeId = 8, FieldTypeName = "image"},
                    new FieldType{FieldTypeId = 9, FieldTypeName = "month"},
                    new FieldType{FieldTypeId = 10, FieldTypeName = "number"},
                    new FieldType{FieldTypeId = 11, FieldTypeName = "password"},
                    new FieldType{FieldTypeId = 12, FieldTypeName = "radio"},
                    new FieldType{FieldTypeId = 13, FieldTypeName = "range"},
                    new FieldType{FieldTypeId = 14, FieldTypeName = "reset"},
                    new FieldType{FieldTypeId = 15, FieldTypeName = "search"},
                    new FieldType{FieldTypeId = 16, FieldTypeName = "submit"},
                    new FieldType{FieldTypeId = 17, FieldTypeName = "tel"},
                    new FieldType{FieldTypeId = 18, FieldTypeName = "time"},
                    new FieldType{FieldTypeId = 19, FieldTypeName = "url"},
                    new FieldType{FieldTypeId = 20, FieldTypeName = "week"}
                };
                foreach (FieldType ft in fieldType)
                {
                    db.FieldTypes.Add(ft);
                }
                db.SaveChanges();
            }
        }
    }
}
