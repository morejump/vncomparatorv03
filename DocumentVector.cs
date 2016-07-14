using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vnComparatorV03
{
    /// <summary>
    /// Represents each document in n-dimensional vector space using Vector Space Model
    /// </summary>
    class DocumentVector
    {
        //Content represents the document(or any other object) to be clustered
        public string Content { get; set; }
        //represents the tf*idf of  each document
        public float[] VectorSpace { get; set; }
    }
}
