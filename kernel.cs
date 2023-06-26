namespace os
{
    class oss
    {
        
        unsafe static void kernel_main()
        {
			   
			   char *fbp=(char* )0xb8000;
			   *((char *)(fbp)) =(char)0x10;
			   
        }
 
        unsafe static void Main()
        {
         kernel_main();
        }
 
    }
}


