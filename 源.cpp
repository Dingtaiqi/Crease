#include<iostream>
#include<fstream>

using namespace std;


class click {
public:
	char ac;          //监视键盘输入，目前纯单压
	struct juge;      //四个判定点于判定位的note，目前先写一个
	int getSize();    //逻辑判断是否到达判定点
	void accept();   //获取键盘监视
	int search();     //在结构体中寻找符合条件的note
	void read();      //格式化谱
};
int click::getSize() {
	switch (ac == 'D') {          //                           需要添加范围判断
		search();

		return 0;
	}
};
struct click::juge {
	int val;
	int x;
	int y;
	int next;
	bool need;
}muisc[11451],D;
int click::search() {
	int i = 0;
	int bef = 11450;
	if (muisc[i].y == D.y) {
		muisc[i].need = false;    //链表删除节点实现note消失
		muisc[bef].next = muisc[i].next;
	}
	 else  bef = i;
	i = muisc[i].next;
}
void click::read() {
	string address;
	address.resize(114514);
	scanf_s("%s", &address[0],114514);
	ifstream fin;
	fin.open(address, ios::in);
	if (!fin)
	{
		std::cerr << "cannot open the file";
	};

}



