global _starts
extern os_oss_kernel_main
_starts:
	call os_oss_kernel_main
haltss:
    jmp haltss
MODULEALIGN       equ     1<<0
MEMINFO           equ     1<<1
FLAGS             equ     MODULEALIGN | MEMINFO
MAGIC             equ     0x1BADB002
CHECKSUM          equ     -(MAGIC + FLAGS)
align 4
dd MAGIC
dd FLAGS
dd CHECKSUM
