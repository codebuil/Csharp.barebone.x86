namespace os
{
    class oss
    {
        unsafe static void printc(byte b,int loc)
        {
        		   int i=loc;
			   byte *fbp=(byte* )i;
			   	*((byte *)(fbp)) =(byte)b;
			   	*((byte *)(fbp+1)) =(byte)0x17;		  
        }
        static void kernel_main()
        {
			   int i=0xb8000;
			   byte b=65;
			   printc(b,i);
			   i=i+2;
			   b++;
			   printc(b,i);
			   i=i+2;
			   b++;
			   printc(b,i);
			   i=i+2;
			   b++;
			   printc(b,i);
			   i=i+2;
			   b++;
			   printc(b,i);
			   i=i+2;
			   b++;
			   printc(b,i);
			   i=i+2;
			   b++;
			   printc(b,i);
			   i=i+2;
			   b++;
			   printc(b,i);
			   i=i+2;
			   b++;
			   			   
			   printc(b,i);
			   i=i+2;
			   b++;
			   printc(b,i);
			   i=i+2;
			   b++;
			   printc(b,i);
			   i=i+2;
			   b++;
			   printc(b,i);
			   i=i+2;
			   b++;
			   printc(b,i);
			   i=i+2;
			   b++;			   
			   printc(b,i);
			   i=i+2;
			   b++;
			   printc(b,i);
			   i=i+2;
			   b++;
			   printc(b,i);
			   i=i+2;
			   b++;
			   printc(b,i);
			   i=i+2;
			   b++;
			   printc(b,i);
			   i=i+2;
			   b++;			   
			   printc(b,i);
			   i=i+2;
			   b++;
			   printc(b,i);
			   i=i+2;
			   b++;
			   printc(b,i);
			   i=i+2;
			   b++;
			   printc(b,i);
			   i=i+2;
			   b++;
			   printc(b,i);
			   i=i+2;
			   b++;			   
			   printc(b,i);
			   i=i+2;
			   b++;
			   printc(b,i);
			   i=i+2;
			   b++;
			   printc(b,i);
			   i=i+2;
			   b++;
			   printc(b,i);
			   i=i+2;
			   b++;
			   printc(b,i);
			   i=i+2;
			   b++;			   
			   printc(b,i);
			   i=i+2;
			   b++;
			   printc(b,i);
			   i=i+2;
			   b++;
			   printc(b,i);
			   i=i+2;
			   b++;
			   printc(b,i);
			   i=i+2;
			   b++;
			   printc(b,i);
			   i=i+2;
			   b++;			   
			   printc(b,i);
			   i=i+2;
			   b++;
			   printc(b,i);
			   i=i+2;
			   b++;
			   printc(b,i);
			   i=i+2;
			   b++;
			   printc(b,i);
			   i=i+2;
			   b++;
			   printc(b,i);
			   i=i+2;
			   b++;
			   
			   
			   	
			   
			  
        }
 
        static void Main()
        {
         kernel_main();
        }
 
    }
}


