
# 题目12“课程设计选题管理系统”
***
#### 1.问题描述
* 课程设计题目包括：编号、名称、关键词、实现技术、人员数（由几个人来完成）等信息。
* 学生信息包括：学号、姓名、性别、年龄、班级、专业等信息。

#### 2.功能要求
（1）添加功能：程序能够添加学生的记录和课程设计题目记录，提供选择界面供用户选择所要添加的类别。添加记录时，要求学号和编号要唯一。如果添加了重复记录，则提示数据添加重复并取消添加。

（2）查询功能：可根据学号、姓名、编号、名称等信息对已添加的学生和课程设计题目进行查询，如果未找到，给出相应的提示信息，如果找到，则显示相应的记录信息。

（3）显示功能：可显示当前系统中所有学生的信息和课程设计题目信息，每条记录占据一行。

（4）编辑功能：可根据查询结果对相应的记录进行修改，修改时注意学号的唯一性。

（5）删除功能：主要实现对已添加的学生和课程设计题目记录进行删除。如果当前系统中没有相应的记录，则提示“记录为空！”并返回操作。

（6）统计功能：能根据多种参数进行统计。能按课程设计题目名称统计出学生选择该题目的人员的信息。

（7）实现普通用户和管理员用户的登录。
