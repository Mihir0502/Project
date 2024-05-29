namespace Basic
{
    public class ImageHandler
    {
        public string Upload(IFormFile file)
        {
            var imgpath = Path.GetExtension(file.FileName);
            long size = file.Length;
            if (size > (5 * 1024 * 1024))
                return ("maximum size recached");
            string fileName = Guid.NewGuid().ToString() + imgpath;
            string path = Path.Combine(Directory.GetCurrentDirectory(), "Images"); // Combine Path create universal path that can be accessed universally 
            using FileStream stream = new FileStream(Path.Combine(path, fileName), FileMode.Create);             // the raw file joh humne store ki hai that is in type byte so to change tthis file so
                                                                                                                 // that we can see and use like normal file so we need to convert in to file stream,
                                                                                                                 // using will automatically open and close the stream.
            file.CopyTo(stream); // copy to is a method to copy the bytes store into our stream and yeh stream store hogi upload folder main
            stream.Dispose();
            return fileName;
        }
    }
}
