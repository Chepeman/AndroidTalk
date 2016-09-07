using System;
namespace TalkExample
{
	public interface IItemTouchHelper
	{
		void OnItemMove(int fromPosition, int toPosition);

		void OnItemDismiss(int position);
	}
}

