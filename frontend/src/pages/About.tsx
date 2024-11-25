import Navbar from "../components/Navbar";

interface Props {}

const About = (props: Props) => {
  return (
    <>
      <div className="bg-home-bg h-screen bg-cover">
        <Navbar />
        <div className="text-white">About us page</div>
      </div>
    </>
  );
};

export default About;
