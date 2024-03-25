
using System.Diagnostics.Tracing;

namespace Task6
{
    public static class Search
    {
        /// <summary>
        /// Simple array linear search
        /// </summary>
        /// <param name="needle">what to find</param>
        /// <param name="hestack">array to search within</param>
        /// <returns>index of entry, or -1 if not found</returns>
        public static int LinearSearch(int needle, int[] heystack)
        {
            int ln = heystack.Length;
            for (int i = 0; i < ln; i++) {
                if (heystack[i] == needle) {
                    return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// Simple array Binary search
        /// </summary>
        /// <param name="needle">what to find</param>
        /// <param name="hestack">array to search within</param>
        /// <returns>index of entry, or -1 if not found</returns>
        public static int BinarySearch(int needle, int[] heystack)
        {
            int left = 0;
            int right = heystack.Length;
            int middle = 0;
            int entry = 0;

            while (left <= right) {
                middle = (left + right) / 2;

                entry = heystack[middle];
                if (entry == needle) {
                    return middle;
                }

                if (needle < entry) {
                    right = middle - 1;
                } else {
                    left = middle + 1;
                }
            }

            return -1;
        }

        /// <summary>
        /// Simple string array Binary search
        /// </summary>
        /// <param name="needle">what to find</param>
        /// <param name="hestack">array to search within</param>
        /// <returns>index of entry, or -1 if not found</returns>
        public static int BinarySearch(string needle, string[] heystack)
        {
            int left = 0;
            int right = heystack.Length;
            int middle = 0;
            int comp = 0;
            string entry = "";

            while (left <= right) {
                middle = (left + right) / 2;

                entry = heystack[middle];
                comp = string.Compare(needle, entry);
                if (comp == 0) {
                    return middle;
                }

                if (comp > 0) {
                    right = middle - 1;
                } else {
                    left = middle + 1;
                }
            }

            return -1;
        }
    }
}