﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using ActionStreetMap.Osm.Entities;
using ActionStreetMap.Osm.Index.Storage;
using NUnit.Framework;

namespace ActionStreetMap.Tests.Osm.Index
{
    [TestFixture]
    public class KeyValueUsageTests
    {
        private ElementStore _elementStore;
        private KeyValueIndex _index;
        private KeyValueStore _kvStore;
        private KeyValueUsage _kvUsage;

        [SetUp]
        public void Setup()
        {
            _kvUsage = new KeyValueUsage(new MemoryStream(1026));

            var keyValueStream = new MemoryStream(new byte[256]);
            keyValueStream.WriteByte(4);
            keyValueStream.WriteByte(7);

            _index = new KeyValueIndex(100, 3);
            _kvStore = new KeyValueStore(_index, _kvUsage, keyValueStream);

            var elementStoreStream = new MemoryStream(new byte[10000]);
            _elementStore = new ElementStore(_kvStore, elementStoreStream);
        }

        [Test]
        public void CanAddAndGet()
        {
            // ARRANGE
            var pair1 = new KeyValuePair<string, string>("tag1", "value1");
            var pair2 = new KeyValuePair<string, string>("tag2", "value2");

            // ACT
            var offset1 = _elementStore.Insert(new Node()
            {
                Id = 1,
                Tags = new Dictionary<string, string> {{pair1.Key, pair1.Value}}
            });
            var offset2 = _elementStore.Insert(new Node()
            {
                Id = 2,
                Tags = new Dictionary<string, string> {{pair1.Key, pair1.Value}, {pair2.Key, pair2.Value}}
            });     
   
            var usageOffset1 = _kvStore.GetUsage(_index.GetOffset(pair1));
            var usageOffset2 = _kvStore.GetUsage(_index.GetOffset(pair2));

            var results1 = _kvUsage.Get(usageOffset1).ToArray();
            var results2 = _kvUsage.Get(usageOffset2).ToArray();
            
            // ASSERT
            Assert.IsNotNull(results1);
            Assert.AreEqual(2, results1.Length);
            Assert.AreEqual(offset1, results1[0]);
            Assert.AreEqual(offset2, results1[1]);

            Assert.IsNotNull(results2);
            Assert.AreEqual(1, results2.Length);
            Assert.AreEqual(offset2, results2[0]);
        }
    }
}
