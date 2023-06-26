namespace os
{
    class oss
    {
        
        unsafe static void kernel_main()
        {
			   
			   byte *fbp=(byte* )0xb8000;
			   *((byte *)(fbp)) =(byte)65;
			   *((byte *)(fbp+1)) =(byte)0x17;
			   
        }
 
        unsafe static void Main()
        {
         kernel_main();
        }
 
    }
}


