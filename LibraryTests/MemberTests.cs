using Library;

namespace LibraryTests
{
    [TestClass]
    public sealed class MemberTests
    {
        [TestMethod]
        public void MemberConstructor_ShouldInitialiseProperties()
        {
            //arrange
            int MemberId = 1;
            string Name = "John Smith";
            string Address = "1 High Street";
            int Phone = 0790090090;

            //act
            Member member = new Member(MemberId, Name, Address, Phone);

            //assert
            Assert.AreEqual(MemberId, member.MemberId);
            Assert.AreEqual(Name, member.Name);
            Assert.AreEqual(Address, member.Address);
            Assert.AreEqual(Phone, member.Phone);
        }
        [TestMethod]
        public void NameProperty_ShouldGetAndSetValue()
        {
            //arrange
            Member member = new Member(1, "John Smith", "1 High Street", 0790090090);
            string newName = "Jane Doe";
            //act
            member.Name = newName;
            //assert
            Assert.AreEqual(newName, member.Name);
        }
    }
}
