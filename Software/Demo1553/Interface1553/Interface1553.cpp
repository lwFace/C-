#include <windows.h>
#include "Interface1553.h"
#include <stdio.h>
#include <time.h>


char gErrMsg[2028]="No error.";
HR_CALLBACK gListener=NULL;
bool gRunFlag = false;

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
	gRunFlag = true;
	CreateThread(NULL,0,recvThread,NULL,0,0);
	return 0;
}

DLL_EXPORT int stop()
{
	gRunFlag = false;
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
	return gErrMsg;
}


inline void gettimeofday(struct timeval *tp, struct timezone * /* = 0 */)
{
	SYSTEMTIME lpSystemTime;
	time_t t;
	t = time(NULL);
	GetSystemTime(&lpSystemTime); 
	tp->tv_usec = lpSystemTime.wMilliseconds*1000;
	tp->tv_sec = (long)t;

}        

DWORD WINAPI recvThread(void* pParam)
{
	CALLBACK_1553 msg;
	memset(&msg,0,sizeof(CALLBACK_1553));
	for (int i=0;i<64;i++)
	{
		msg.payload[i] = i;
	}
	struct timeval tNow;
	while(gRunFlag)
	{
		if (gListener==NULL)
		{
			Sleep(1000);
			continue;
		}		
		for (int i=0;i<31;i++)
		{		
			if (!gRunFlag)
			{
				break;
			}
			gettimeofday(&tNow,NULL);
			msg.cmd1=0x840;
			msg.srcAddr = 1;
			msg.subSrcAddr = 1;
			msg.dstAddr = 255;
			msg.subDstAddr = 255;
			msg.length = i+1;	
			msg.sec = tNow.tv_sec;
			msg.usec = tNow.tv_usec;
			msg.src = 0;//BC
			gListener(&msg,NULL);
			msg.src = 1;//RT
			gListener(&msg,NULL);
			msg.src = 2;//BM
			gListener(&msg,NULL);
			Sleep(1000);
		}
	}
	return 0;
}