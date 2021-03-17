//SUMMARY
//Intro for the webpage animation
const tl = gsap.timeline({ defaults: { ease: 'power1.out' } });

tl.to('.intro', { y: '-100%', duration: 1 }, "-=1");
tl.fromTo('nav', { opacity: 0 }, { opacity: 1, duration: 1 })
tl.fromTo('.center-logo', { opacity: 0 }, { opacity: 1, duration: 1 })
//SUMMARY END