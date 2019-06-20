using System;
using System.Configuration;
using System.Windows.Forms;
using System.Xml;

namespace CHBK2014_N9.Data.Helper
{
 internal   class MyConfig
    {

        private XmlNode node;

        private string _cfgFile;

        public string ConfigFile
        {
            get
            {
                return this._cfgFile;
            }
            set
            {
                this._cfgFile = string.Concat(Application.StartupPath, "\\", value);
            }
        }

        public MyConfig()
        {
            this._cfgFile = string.Concat(Application.ExecutablePath, ".Config");
        }

        public string GetValue(string key)
        {
            return Convert.ToString(this.GetValue(key, typeof(string)));
        }

        public new object GetValue(string key, Type sType)
        {
            object str;
            XmlDocument xmlDocument = new XmlDocument();
            object empty = string.Empty;
            this.loadDoc(xmlDocument);
            string str1 = key.Substring(0, key.LastIndexOf("//"));
            try
            {
                this.node = xmlDocument.SelectSingleNode(str1);
                if (this.node != null)
                {
                    XmlElement xmlElement = (XmlElement)this.node.SelectSingleNode(key);
                    if (xmlElement != null)
                    {
                        empty = xmlElement.GetAttribute("value");
                    }
                }
                if (sType == typeof(string))
                {
                    str = Convert.ToString(empty);
                }
                else if (sType == typeof(bool))
                {
                    if (empty.Equals("True") || empty.Equals("False"))
                    {
                        str = Convert.ToBoolean(empty);
                    }
                    else
                    {
                        str = false;
                    }
                }
                else if (sType == typeof(int))
                {
                    str = Convert.ToInt32(empty);
                }
                else if (sType == typeof(double))
                {
                    str = Convert.ToDouble(empty);
                }
                else if (sType != typeof(DateTime))
                {
                    str = Convert.ToString(empty);
                }
                else
                {
                    str = Convert.ToDateTime(empty);
                }
            }
            catch
            {
                str = string.Empty;
            }
            return str;
        }

        private void loadDoc(XmlDocument doc)
        {
            doc.Load(this._cfgFile);
        }

        public bool removeElement(string key)
        {
            bool flag;
            XmlDocument xmlDocument = new XmlDocument();
            this.loadDoc(xmlDocument);
            try
            {
                string str = key.Substring(0, key.LastIndexOf("//"));
                this.node = xmlDocument.SelectSingleNode(str);
                if (this.node != null)
                {
                    XmlNode xmlNodes = this.node.SelectSingleNode(key);
                    this.node.RemoveChild(xmlNodes);
                    this.saveDoc(xmlDocument, this._cfgFile);
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                flag = false;
            }
            return flag;
        }

        private void saveDoc(XmlDocument doc, string docPath)
        {
            if (this._cfgFile.Equals("web.config"))
            {
                return;
            }
            try
            {
                XmlTextWriter xmlTextWriter = new XmlTextWriter(docPath, null)
                {
                    Formatting = Formatting.Indented
                };
                doc.WriteTo(xmlTextWriter);
                xmlTextWriter.Flush();
                xmlTextWriter.Close();
            }
            catch
            {
            }
        }

        public bool SetValue(string key, string val)
        {
            bool flag;
            XmlDocument xmlDocument = new XmlDocument();
            this.loadDoc(xmlDocument);
            try
            {
                string str = key.Substring(0, key.LastIndexOf("//"));
                this.node = xmlDocument.SelectSingleNode(str);
                if (this.node != null)
                {
                    XmlElement xmlElement = (XmlElement)this.node.SelectSingleNode(key);
                    if (xmlElement == null)
                    {
                        str = key.Substring(key.LastIndexOf("//") + 2);
                        XmlElement xmlElement1 = xmlDocument.CreateElement(str.Substring(0, str.IndexOf("[@")).Trim());
                        str = str.Substring(str.IndexOf("'") + 1);
                        xmlElement1.SetAttribute("key", str.Substring(0, str.IndexOf("'")));
                        xmlElement1.SetAttribute("value", val);
                        this.node.AppendChild(xmlElement1);
                    }
                    else
                    {
                        xmlElement.SetAttribute("value", val);
                    }
                    this.saveDoc(xmlDocument, this._cfgFile);
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            catch
            {
                flag = false;
            }
            return flag;
        }
    }
}
