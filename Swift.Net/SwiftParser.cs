using Swift.Net.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Swift.Net
{
    public class SwiftParser
    {
        public SwiftParser()
        {
        }

        public SwiftMessage GetSwiftMessage(string messageText)
        {
            return Parse(messageText);
        }

        private SwiftMessage Parse(string messageText)
        {
            List<string> blocks = ReadBlocks(messageText);
            if ((blocks == null) || (blocks.Count == 0))
                throw new SwiftParserException("Error while reading blocks");

            SwiftMessage swiftMessage = new SwiftMessage();
            foreach (var blockText in blocks)
            {
                SwiftBlockBase block = CreateBlock(blockText);
                swiftMessage.SetBlock(block);
            }

            return swiftMessage;
        }

        private SwiftBlockBase CreateBlock(string blockText)
        {
            int blockIdentifier = IdentifyBlock(blockText);
            switch (blockIdentifier)
            {
                case 1:
                    return new SwiftBlock1(blockText);
                case 2:
                    Direction direction = GetDirection(blockText);
                    if (direction == Direction.Input)
                        return new SwiftBlock2Input(blockText);
                    if (direction == Direction.Output)
                        return new SwiftBlock2Output(blockText);
                    break;
                case 3:
                    return new SwiftBlock3(blockText);
                case 4:
                    return new SwiftBlock4(blockText);
                case 5:
                    return new SwiftBlock5(blockText);
            }
            return null;
        }

        private List<string> ReadBlocks(string messageText)
        {
            if ((messageText == null) || (messageText.Trim().Length == 0))
                throw new SwiftParserException("The message is empty");

            List<string> groupList = new List<string>();

            int start = 0;
            bool checkNestedBlockStart = false;
            int nestedBlockStartCount = 0;
            for (int i = 0; i < messageText.Length; i++)
            {
                char c = messageText[i];

                if (IsBlockStart(c))
                {
                    if (checkNestedBlockStart)
                        nestedBlockStartCount++;
                    else
                        checkNestedBlockStart = true;
                }
                else if (IsBlockEnd(c))
                {
                    if (checkNestedBlockStart && (nestedBlockStartCount > 0))
                        nestedBlockStartCount--;
                    else
                    {
                        string group = messageText.Substring(start + 1, i - start - 1);
                        groupList.Add(group);
                        start = i + 1;
                        checkNestedBlockStart = false;
                    }
                }
            }

            return groupList;
        }

        private bool IsBlockStart(char c)
        {
            return (c == '{') ? true : false;
        }

        private bool IsBlockEnd(char c)
        {
            return (c == '}') ? true : false;
        }

        private int IdentifyBlock(string block)
        {
            if ((block != null) && (block.Length > 1))
            {
                char c = block[0];
                if ('0' <= c && c <= '5')
                {
                    return (int)char.GetNumericValue(c);
                }
            }
            throw new SwiftParserException("The block identifier must be between 1 and 5");
        }

        private Direction GetDirection(string block)
        {
            int i = block.IndexOf(':');
            if (block.Length > i + 1)
            {
                char c = char.ToUpper(block[i + 1]);
                if (c == 'I')
                    return Direction.Input;
                if (c == 'O')
                    return Direction.Output;
            }
            throw new SwiftParserException("The direction must be \"I\" or \"O\"");
        }
    }
}
