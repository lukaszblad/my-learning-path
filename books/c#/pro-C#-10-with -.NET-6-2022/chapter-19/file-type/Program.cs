// very similar to file info type, can be often used insted of file info
var fileName = $@"C{Path.VolumeSeparatorChar}{Path.DirectorySeparatorChar}Test.dat";
//Using File instead of FileInfo
using (FileStream fs8 = File.Create(fileName))
{
    // Use the FileStream object...
}
File.Delete(fileName);
// Make a new file via FileInfo.Open().
using(FileStream fs9 = File.Open(fileName,
FileMode.OpenOrCreate, FileAccess.ReadWrite,
FileShare.None))
{
    // Use the FileStream object...
}
// Get a FileStream object with read-only permissions.
using(FileStream readOnlyStream = File.OpenRead(fileName))
{}
File.Delete(fileName);
// Get a FileStream object with write-only permissions.
using(FileStream writeOnlyStream = File.OpenWrite(fileName))
{}
// Get a StreamReader object.
using(StreamReader sreader = File.OpenText(fileName))
{}
File.Delete(fileName);
// Get some StreamWriters.
using(StreamWriter swriter = File.CreateText(fileName))
{}
File.Delete(fileName);
using(StreamWriter swriterAppend =
File.AppendText(fileName))
{}
File.Delete(fileName);
