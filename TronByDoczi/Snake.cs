using System.Collections.Generic;
using System.Drawing;

namespace TronByDoczi
{
    internal class Snake
    {
        public List<Point> Body { get; private set; }
        public int Length { get { return Body.Count; } }
        public Direction Direction { get; set; } // publikus directions

        public Snake()
        {
            Body = new List<Point>
        {
            new Point(10, 10), // Kezdő snake pos.
        };
            Direction = Direction.Right;
        }

        public void Move()
        {
            Point newHead = GetNewHead();
            Body.Insert(0, newHead);
            Body.RemoveAt(Length - 1);
        }

        private Point GetNewHead()
        {
            Point head = Body[0];
            Point newHead = head;

            switch (Direction)
            {
                case Direction.Up:
                    newHead.Y--;
                    break;
                case Direction.Down:
                    newHead.Y++;
                    break;
                case Direction.Left:
                    newHead.X--;
                    break;
                case Direction.Right:
                    newHead.X++;
                    break;
            }

            return newHead;
        }

        public void ChangeDirection(Direction newDirection)
        {
            if (IsOppositeDirection(newDirection))
                return;

            Direction = newDirection;
        }

        private bool IsOppositeDirection(Direction newDirection)
        {
            if ((Direction == Direction.Up && newDirection == Direction.Down) ||
                (Direction == Direction.Down && newDirection == Direction.Up) ||
                (Direction == Direction.Left && newDirection == Direction.Right) ||
                (Direction == Direction.Right && newDirection == Direction.Left))
            {
                return true;
            }
            return false;
        }
    }

    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }

}
