﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wifi.PlaylistEditor.Types;

//private IPlaylistItem _fixture;

//COVERAGE (Unter Extensions -> Manager ) -> Teste
//3 Must Have (AAA-Prinzip)
//  ---1> Arrange (Arrangieren | Variablen vorbereiten)
//  ---2> Act (Ausführen)
//  ---3> Assert (Prüfen)


namespace Wifi.PlaylistEditor.Items.Tests
{
    [TestFixture]
    public class Mp3ItemTests
    {
        private IPlaylistItem _fixture;
        Guid myGuid = Guid.NewGuid();
        FileInfo myTestFile = new FileInfo("Dummmy-Path");


        [Test]
        public void GetTitle()
        {
            //arrange
            myTestFile = new FileInfo(@"C:\Users\user\Music\TestMediaFiles\001 - Bruno Mars - Grenade.mp3");
            _fixture = new Mp3Item(myTestFile, myGuid);

            //act
            var title = _fixture.Title;

            //assert
            Assert.That(title, Is.Not.Null);
            Assert.That(title, Is.EqualTo("Grenade"));
        }

        [Test]
        public void GetDuration()
        {
            //arrange
            myTestFile = new FileInfo(@"C:\Users\user\Music\TestMediaFiles\001 - Bruno Mars - Grenade.mp3");
            _fixture = new Mp3Item(myTestFile, myGuid);

            //act
            var duration = _fixture.Duration;

            //assert            
            Assert.That(duration, Is.EqualTo(TimeSpan.FromSeconds(222.188)));
        }

        [Test]
        public void GetTitle_FilePathIsNull()
        {
            //arrange
            var fixture = new Mp3Item(null, myGuid);

            //act
            var title = fixture.Title;

            //assert            
            Assert.That(title, Is.EqualTo("--[File not found]--"));
        }

        [Test]
        public void GetTitle_FilePathIsEmpty()
        {
            //arrange
            var fixture = new Mp3Item(null, myGuid);

            //act
            var title = fixture.Title;

            //assert            
            Assert.That(title, Is.EqualTo("--[File not found]--"));
        }

        [Test]
        public void GetTitle_FilePathNotExists()
        {
            //arrange
            myTestFile = new FileInfo(@"c:\mysupermusic\hits\gandalfSong.mp3");
            var fixture = new Mp3Item(myTestFile, myGuid);

            //act
            var title = fixture.Title;

            //assert            
            Assert.That(title, Is.EqualTo("--[File not found]--"));
        }
    }
}
