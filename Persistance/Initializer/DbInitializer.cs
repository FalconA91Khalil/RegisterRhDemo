using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistance.Initializer
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext db)
        {
            db.Database.EnsureCreated();

            var form = new Form[]
            {
                new Form{FormId = 1, FormType = "Company"}
            };
            foreach(Form f in form)
            {
                db.Forms.Add(f);
            }
            db.SaveChanges();

            var section = new Section[]
            {
                new Section{SectionId = 1, SectionName = "Default", IsDefault = true}
            };
            foreach(Section s in section)
            {
                db.Sections.Add(s);
            }
            db.SaveChanges();

            var fieldType = new FieldType[]
            {
                new FieldType{FieldTypeId = 1, FieldTypeName = "button"},
                new FieldType{FieldTypeId = 1, FieldTypeName = "checkbox"},
                new FieldType{FieldTypeId = 1, FieldTypeName = "date"},
                new FieldType{FieldTypeId = 1, FieldTypeName = "datetime-local"},
                new FieldType{FieldTypeId = 1, FieldTypeName = "email"},
                new FieldType{FieldTypeId = 1, FieldTypeName = "file"},
                new FieldType{FieldTypeId = 1, FieldTypeName = "hidden"},
                new FieldType{FieldTypeId = 1, FieldTypeName = "image"},
                new FieldType{FieldTypeId = 1, FieldTypeName = "month"},
                new FieldType{FieldTypeId = 1, FieldTypeName = "number"},
                new FieldType{FieldTypeId = 1, FieldTypeName = "password"},
                new FieldType{FieldTypeId = 1, FieldTypeName = "radio"},
                new FieldType{FieldTypeId = 1, FieldTypeName = "range"},
                new FieldType{FieldTypeId = 1, FieldTypeName = "reset"},
                new FieldType{FieldTypeId = 1, FieldTypeName = "search"},
                new FieldType{FieldTypeId = 1, FieldTypeName = "submit"},
                new FieldType{FieldTypeId = 1, FieldTypeName = "tel"},
                new FieldType{FieldTypeId = 1, FieldTypeName = "time"},
                new FieldType{FieldTypeId = 1, FieldTypeName = "url"},
                new FieldType{FieldTypeId = 1, FieldTypeName = "week"}
            };
            foreach (FieldType ft in fieldType)
            {
                db.FieldTypes.Add(ft);
            }
            db.SaveChanges();

        }
    }
}
