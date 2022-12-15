using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgProject.LabForms;

//数组排序状态类
public class ArraySortState
{
	public readonly int Code;
	public readonly string Display;

	public ArraySortState(int code, string display)
	{
		Code = code;
		Display = display;
	}

	public override string ToString()
	{
		return $"数组状态是{Display}，代码为{Code}。";
	}

	public static readonly ArraySortState Unsorted = new ArraySortState(0, "未排序");
	public static readonly ArraySortState Ascending = new ArraySortState(1, "升序");
	public static readonly ArraySortState Descending = new ArraySortState(2, "降序");
	public static readonly ArraySortState AscendingToDescending = new ArraySortState(3, "先升后降");
	public static readonly ArraySortState DescendingToAscending = new ArraySortState(4, "先降后升");
}
