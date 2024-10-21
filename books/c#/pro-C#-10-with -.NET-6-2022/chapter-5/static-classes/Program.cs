// These compile just fine. 
using StaticDataAndMembers;

TimeUtilClass.PrintDate();
TimeUtilClass.PrintTime();
// Compiler error! Can't create instance of static classes! 
// TimeUtilClass u = new TimeUtilClass();
