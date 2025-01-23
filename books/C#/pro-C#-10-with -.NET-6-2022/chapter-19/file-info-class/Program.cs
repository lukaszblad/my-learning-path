// used to obtain iunfo on files

FileInfo f = new FileInfo("file-info-test.txt");
FileStream fs = f.Create();
Thread.Sleep(3000);
f.Delete();
fs.Close();
