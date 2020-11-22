using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteMakingApp.Models;

namespace NoteMakingApp.ViewComponents.AccountVC
{
    public partial class InformationEditor : UserControl
    {
        public int account;
        public NoteMakingApp.Models.Account password;
        public Person person;
        private static InformationEditor instance;
        public InformationEditor()
        {
            InitializeComponent();
            instance = this;
        }
        public static InformationEditor getInstance(int acc, string cat, List<PersonalDetail>details=null, Person per=null)
        {
            instance.lbTitle.Text = cat;
            instance.account = acc;
            instance.person = per;
            instance.pnlEditors.Controls.Clear();
            if (per == null)
            {
                foreach (PersonalDetail d in details)
                {
                    EditionItem item = new EditionItem(d, false);
                    item.Location = new System.Drawing.Point(0, instance.pnlEditors.Controls.Count * item.Height);
                    instance.pnlEditors.Controls.Add(item);
                }
            }
            else

            {
                PersonalDetail d;
                d = new PersonalDetail()
                {
                    account = instance.account,
                    category = "General",
                    subcategory = "Name",
                    content = instance.person.introduction,
                };
                EditionItem item = new EditionItem(d, true);
                item.Location = new System.Drawing.Point(0, instance.pnlEditors.Controls.Count * item.Height);

                instance.pnlEditors.Controls.Add(item);
                d = new PersonalDetail()
                {
                    account = instance.account,
                    category = "General",
                    subcategory = "Introduction",
                    content = instance.person.name,
                };
                item = new EditionItem(d, per == null);
                item.Location = new System.Drawing.Point(0, instance.pnlEditors.Controls.Count * item.Height);
                instance.pnlEditors.Controls.Add(item);

                d = new PersonalDetail()
                {
                    account = instance.account,
                    category = "General",
                    subcategory = "Password",
                    content = "",
                };
                item = new EditionItem(d, per == null);
                item.Location = new System.Drawing.Point(0, instance.pnlEditors.Controls.Count * item.Height);
                instance.pnlEditors.Controls.Add(item);
            }
            return instance;
        }
        public static InformationEditor getInstance() { return instance; }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (person == null)
            {
                PersonalDetail d = new PersonalDetail()
                {
                    account = account,
                    category = lbTitle.Text,
                };
                EditionItem item = new EditionItem(d, false, true);
                item.Location = new System.Drawing.Point(0, this.pnlEditors.Controls.Count * item.Height);
                this.pnlEditors.Controls.Add(item);
            }
        }
        public void SaveChanges()
        {
            foreach(EditionItem i in this.pnlEditors.Controls)
            {
                switch (i.function)
                {
                    case 0:
                        break;
                    case 1:
                        DataHandle.getInstance().deleteDetail(i.getOriginalDetail());
                        break;
                    case 2:
                        if (!i.isGeneralDetail)
                        {
                            DataHandle.getInstance().updateDetail(i.getOriginalDetail(), i.generateDetail());
                        }
                        else
                        {
                            switch (i.originDetail.subcategory)
                            {
                                case "Introduction":
                                    person.introduction = i.GetContent();
                                    DataHandle.getInstance().UpdatePerson(person);
                                    break;
                                case "Name":
                                    person.name = i.GetContent();
                                    DataHandle.getInstance().UpdatePerson(person);
                                    break;
                                case "Password":
                                    password = i.GetAccount();
                                    DataHandle.getInstance().UpdateAccount(password);
                                    break;
                            }
                        }
                        
                        break;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
            AccountSubwindow.EraseInformationEditor();
        }
    }
}
