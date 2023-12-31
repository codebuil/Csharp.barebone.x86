printf "\ec\e[44;37m\n"
rm *.o
rm *.elf
rm *.img
rm *.exe
rm *.dll
nasm -felf32 -o boot.o boot.S
mcs -unsafe kernel.cs -o kernel.exe
mono --aot=asmonly kernel.exe
sed 's/local os_oss_kernel_main/globl os_oss_kernel_main/g' kernel.exe.s > kernel.s.s
as kernel.s.s -o kernel.o 
gcc link.ld boot.o kernel.o -o kernel.elf -nostdlib
objcopy kernel.elf -O binary kernel.bin
qemu-system-i386 -kernel kernel.elf
