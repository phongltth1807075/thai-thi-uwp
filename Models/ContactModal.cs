using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bai_thi_uwp.Entity;
using bai_thi_uwp.Ultils;

namespace bai_thi_uwp.Models
{
    class ContactModal
    {
        public bool Insert(Contact contact)

        {

            try

            {

                using (var stt = SQLiteUtilc.GetIntances().Connection.Prepare("INSERT INTO Contact (Name, PhoneNumber) VALUES (? , ?)"))

                {

                    stt.Bind(1, contact.Name);

                    stt.Bind(2, contact.PhoneNumber);

                    stt.Step();

                    return true;

                }

            }

            catch (Exception ex)

            {

                Debug.WriteLine(ex.Message);

            }

            return false;

        }
        public List<Contact> Select()

        {

            try

            {

                List<Contact> listContact = new List<Contact>();

                using (var stt = SQLiteUtilc.GetIntances().Connection.Prepare("SELECT * from Contact"))

                {

                    while (stt.Step() == SQLitePCL.SQLiteResult.ROW)

                    {

                        var getContact = new Contact();

                        getContact.Id = Convert.ToInt32(stt[0]);

                        getContact.Name = (string)stt[1];

                        getContact.PhoneNumber = (string)stt[2];

                        listContact.Add(getContact);

                    }

                    return listContact;

                }

            }

            catch (Exception ex)

            {

                Debug.WriteLine(ex.Message);

                return null;

            }

        }
    }
}
