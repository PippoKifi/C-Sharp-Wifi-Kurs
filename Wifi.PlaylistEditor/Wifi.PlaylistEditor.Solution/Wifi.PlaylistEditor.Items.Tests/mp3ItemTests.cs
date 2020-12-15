using NUnit.Framework;
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
//  ---2> Act (Ausführen) | Ist meistens einen einzeiler
//  ---3> Assert (Prüfen)


namespace Wifi.PlaylistEditor.Items.Tests
{
    [TestFixture]
    public class Mp3ItemTests
    {
        private IPlaylistItem _fixture;
        Guid myGuid = Guid.NewGuid();
        FileInfo myTestFile = new FileInfo("Dummmy-Path");

        [SetUp] //Wird vor jedem einzelnen Test ausgeführt
        public void TestInit()
        {
            myTestFile = new FileInfo(@"C:\Users\user\Music\TestMediaFiles\001 - Bruno Mars - Grenade.mp3");
            _fixture = new Mp3Item(myTestFile, myGuid);
        }


        [Test]
        public void GetTitle()
        {
            //arrange

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
   
            //act
            var duration = _fixture.Duration;

            //assert            
            Assert.That(duration, Is.EqualTo(TimeSpan.FromSeconds(222.188)));
        }

        [Test]
        public void GetArtist()
        {
            //arrange
        
            //act
            var duration = _fixture.Artist;

            //assert            
            Assert.That(duration, Is.EqualTo("Bruno Mars"));
        }

        [Test]
        public void GetPath()
        {
            var demoMp3Path = @"C:\Users\user\Music\TestMediaFiles\001 - Bruno Mars - Grenade.mp3";

            //arrange
            myTestFile = new FileInfo(demoMp3Path);
            _fixture = new Mp3Item(myTestFile, myGuid);

            //act
            var duration = _fixture.Path;

            //assert            
            Assert.That(duration, Is.EqualTo(demoMp3Path));
        }

        [Test]
        public void GetThumnail()
        {
            var demoMp3Path = @"C:\Users\user\Music\TestMediaFiles\001 - Bruno Mars - Grenade.mp3";

            //arrange
            myTestFile = new FileInfo(demoMp3Path);
            _fixture = new Mp3Item(myTestFile, myGuid);

            //act
            var thumbnail = _fixture.Thumbnail;

            //assert            
            Assert.That(thumbnail, Is.Not.Null);
            //Assert.That(thumbnail.Size);
        }

        [Test]
        public void GetThumnail_WhitMp3FileWhitNoImage()
        {
            var demoMp3Path = @"C:\Users\user\Music\TestMediaFiles\002 - Lena - Taken By A Stranger.mp3";

            //arrange
            myTestFile = new FileInfo(demoMp3Path);
            _fixture = new Mp3Item(myTestFile, myGuid);

            //act
            var thumbnail = _fixture.Thumbnail;

            //assert            
            Assert.That(thumbnail, Is.Null);
            //Assert.That(thumbnail.Size);
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
            var fixture = new Mp3Item(string.Empty, myGuid);

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
