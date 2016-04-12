#include <iostream>
#include <vector>
using namespace std;
int main()
{
vector<char> sl;
int n,k;
cin >>n>>k;
for (int i = 0; i < n; ++i){
char c;
		cin >> c;		
		sl.push_back(c);
}
for (int i = 0; i < n; ++i)
{
	if ((int)sl[i]<110)
	{
	if (k<=122-(int)sl[i]) {sl[i]=(char)((int)sl[i]+k); k=0; break;}
	else 
	{
		k-=122-(int)sl[i];
		sl[i]='z';
	}
	}
	else
	{
if (k<=(int)sl[i]-97) {sl[i]=(char)((int)sl[i]-k); k=0; break;}
	else 
	{
		k-=(int)sl[i]-97;
		sl[i]='a';
	}
	}
}
if (k>0) {cout << "-1";}
else {
for (int i = 0; i < n; ++i)
{
	cout << sl[i];
}
}
	return 0;
}