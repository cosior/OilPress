using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace OilPress
{
    /// <summary>
    /// Manage the Users Database File for Login.
    /// </summary>
    class FileHandler
    {
        String localFilename;
        FileInfo filer;
        String[] tempdata; // to writeback the users 
        int editPosition;  // to know where to write

        /// <summary>
        /// Constructor with filename as a parameter. Recomented filename "users.bin".
        /// </summary>
        /// <param name="filename"></param>
        public FileHandler(String filename)
        {
            this.localFilename = filename;
            filer = new FileInfo(filename);
        }

        /// <summary>
        /// Check to see if Users Database File Exist.
        /// </summary>
        /// <returns></returns>
        public bool FileExist()
        {
            return (filer.Exists);
        }

        /// <summary>
        /// Create a new Database File for Users Login. Default Username = admin, Password = admin
        /// </summary>
        /// <returns></returns>
        public bool CreateFile()
        {
            FileStream fsUsers = new FileStream(localFilename, FileMode.Create);
            BinaryWriter fileWriter = new BinaryWriter(fsUsers);

            String[] data = new String[] { "admin", "admin", "costas", "763899" };
            for (int i = 0; i < data.Length; i++)
            {
                // write default values to file
                fileWriter.Write(data[i]);
            }
            fileWriter.Close();
            fsUsers.Close();
            return (true);
        }

        /// <summary>
        /// Check to see if Username Exist in Database File. Return User positon > 0 or (-1) if not Found
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public int FindUser(String username, String password)
        {
            FileStream fsUsers = new FileStream(localFilename, FileMode.Open);
            BinaryReader fileReader = new BinaryReader(fsUsers);
            String name;
            String pass;
            int position = 0;

            while (fileReader.BaseStream.Position < fileReader.BaseStream.Length)
            {
                name = fileReader.ReadString();
                pass = fileReader.ReadString();

                if (username.Equals(name))
                {
                    if (password.Equals(pass))
                    {
                        fileReader.Close();
                        fsUsers.Close();
                        return (position);
                    }
                }
                position++;
            }
            // if file is checked no user found.
            fileReader.Close();
            fsUsers.Close();
            return (-1);
        }

        /// <summary>
        /// Count the Users in Database File
        /// </summary>
        /// <returns></returns>
        public int countFile()
        {
            FileStream fsUsers = new FileStream(localFilename, FileMode.Open);
            BinaryReader fileReader = new BinaryReader(fsUsers);
            int i = 0;
            while (fileReader.BaseStream.Position < fileReader.BaseStream.Length)
            {
                fileReader.ReadString();
                fileReader.ReadString();
                i++;
            }
            fileReader.Close();
            fsUsers.Close();
            return (i);
        }

        /// <summary>
        /// First check if User Exist(Get Position). Then send the Data for Editing The User in Current Position
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        public bool EditUser(String username, String password, int position)
        {
            editPosition = position; // assign to global variable
            int length = countFile();
            tempdata = new String[length * 2]; // assign length to string array

            FileStream fsUsers = new FileStream(localFilename, FileMode.Open);
            BinaryReader fileReader = new BinaryReader(fsUsers);

            int i = 0, j = 0;
            while (fileReader.BaseStream.Position < fileReader.BaseStream.Length)
            {
                if (i == position)
                {
                    fileReader.ReadString();
                    tempdata[i + j] = username;
                    fileReader.ReadString();
                    tempdata[i + j + 1] = password;
                    i++;
                    j++;
                }
                else
                {
                    tempdata[i + j] = fileReader.ReadString();
                    tempdata[i + j + 1] = fileReader.ReadString();
                    i++;
                    j++;
                }
            }
            fileReader.Close();
            fsUsers.Close();
            return (writebackdata());
        }

        /// <summary>
        /// Insert New User In Database File if not Exist.If User Exist return (1) , if User Added Ok return (0).
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public int InsertUser(String username, String password)
        {
            if ((FindUser(username, password)) >= 0)
            {
                return (1);
            }
            else
            {
                FileStream fsUsers = new FileStream(localFilename, FileMode.Append);
                BinaryWriter fileWriter = new BinaryWriter(fsUsers);

                try
                {
                    fileWriter.Write(username);
                    fileWriter.Write(password);
                    fileWriter.Close();
                    fsUsers.Close();
                    return (0);
                }
                catch (Exception)
                {
                    fileWriter.Close();
                    fsUsers.Close();
                    return (-1);
                }
            }
        }

        /// <summary>
        /// Delete User for Database File. Return "true" if ok or "fulse" on Error
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public bool DeleteUser(int position)
        {
            int length = countFile();
            tempdata = new String[(length-1) * 2]; // assign length to string array -1 for deleted user

            FileStream fsUsers = new FileStream(localFilename, FileMode.Open);
            BinaryReader fileReader = new BinaryReader(fsUsers);

            int i = 0, j = 0;
            while (fileReader.BaseStream.Position < fileReader.BaseStream.Length)
            {
                if (i == position)
                {
                    // skip user to delete it
                    fileReader.ReadString();
                    fileReader.ReadString();
                }
                if (i == (length - 1)) { break; }

                tempdata[i + j] = fileReader.ReadString();
                tempdata[i + j + 1] = fileReader.ReadString();
                i++;
                j++;
            }
            fileReader.Close();
            fsUsers.Close();
            return (writebackdata());
        }

        /// <summary>
        /// Return all Users in database in Array form.
        /// </summary>
        /// <returns></returns>
        public String[] GetUsers()
        {
            int size;
            size = countFile();
            tempdata = new String[size * 2];

            FileStream fsUsers = new FileStream(localFilename, FileMode.Open);
            BinaryReader fileReader = new BinaryReader(fsUsers);
            
            int i = 0, j = 0;
            while (fileReader.BaseStream.Position < fileReader.BaseStream.Length)
            {
                tempdata[i + j] = fileReader.ReadString();
                tempdata[i + j + 1] = fileReader.ReadString();
                i++;
                j++;
            }
            fileReader.Close();
            fsUsers.Close();

            return (tempdata);
        }

        private bool writebackdata()
        {
            FileStream fsUsers = new FileStream(localFilename, FileMode.Create);
            BinaryWriter fileWriter = new BinaryWriter(fsUsers);

            for (int i = 0; i < tempdata.Length; i++)
            {
                // write edit data back to file
                fileWriter.Write(tempdata[i]);
            }

            fileWriter.Close();
            fsUsers.Close();

            return (true);
        }
    }
}
