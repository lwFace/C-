#include "Interface1553.h"
#include <stdio.h>

char gErrMsg[2028]="No error.";
HR_CALLBACK gListener;

DLL_EXPORT int open(char* confStr)
{
	return 0;
}

DLL_EXPORT int init(char* initStr)
{
	printf("%s\n",initStr);
	return 0;
}

DLL_EXPORT int start()
{
	return 0;
}

DLL_EXPORT int stop()
{
	return 0;
}

DLL_EXPORT int writeMsg(int msgId,char* pPayload,int nLen)
{
	return 0;
}

DLL_EXPORT void addListener(HR_CALLBACK listener)
{
	gListener = listener;
}

DLL_EXPORT int close(char* confStr)
{
	return 0;
}

DLL_EXPORT char* getLastErr()
{
	CALLBACK_1553 info;
	info.cmd1 = 100;
	info.payload[0] = 12;
	gListener((void*)&info,NULL);
	return gErrMsg;
}
