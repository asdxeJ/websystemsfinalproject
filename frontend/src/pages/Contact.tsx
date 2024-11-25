import Navbar from "../components/Navbar";

interface Props {}

const Contact = (props: Props) => {
  return (
    <>
      <div className="bg-home-bg h-screen bg-cover">
        <Navbar />
        <div className="text-white">Contact page</div>
      </div>
    </>
  );
};

export default Contact;
