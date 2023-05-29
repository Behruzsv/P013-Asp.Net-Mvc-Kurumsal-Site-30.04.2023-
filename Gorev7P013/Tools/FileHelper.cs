namespace Gorev7P013.Tools
{
    public class FileHelper
    {
        public static async Task<string> FileLoaderAsync(IFormFile formFile, string klasorYolu = "/wwwroot/Image/")
        {
            string dosyaAdi = "";
            dosyaAdi = formFile.FileName;
            string dizin = Directory.GetCurrentDirectory(); 
            dizin += klasorYolu + dosyaAdi; 
            using var stream = new FileStream(dizin, FileMode.Create);
            await formFile.CopyToAsync(stream); 

            return dosyaAdi; 
        }
    }
}
