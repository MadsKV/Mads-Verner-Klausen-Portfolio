/*
 * Microchip_intro.c
 *
 * Created: 17-05-2022 11:04:35
 * Author : MadsV
 */ 

#include <avr/io.h>


int main(void)
{
    /* Replace with your application code */
	DDRB = 0xFF;
	PORTB = PORTB | 0x26;

	// Med kodelinjen herunder sætter vi bit 4 i
	// Port B.
	PORTB |= (1<< PB4);
	PORTB = 0x11;
	
	//PORTB |= (1<< PB3);
	//PORTB |= (1<< PB5);
	// Med kodelinjen herunder sætter vi bit 3 og 
	// bit 5 i Port B.
	PORTB |= (1<< PB3) | (1 << PB5);
	// Med kodelinjen herunder clearer vi bit 0 og
	// i Port B.
	PORTB &= ~(1 << PB0);	

	// Med kodelinjen herunder clearer vi bit 3 og
	// bit 5 i Port B.
	PORTB &= ~( (1 << PB3) | (1 << PB5));
	
	PORTB ^= (1 << PB2);
	
	PORTB ^= (1 << PB6) | (1 << PB7);
	PORTB ^= (1 << PB6) | (1 << PB7);
	
	PORTB |= (1<< PB6) || (1 << PB7);
	

	uint8_t Tal1_8bit = 0x0A;
	uint8_t Tal2_8bit = 0x14;

	uint16_t Tal1_16bit = 0x0064;
	uint16_t Tal2_16bit = 0x00C8;


	uint8_t *p8bit;
	uint16_t *p16bit;


	p8bit = &Tal1_8bit;
	p16bit = &Tal1_16bit;

	p8bit++;
	p16bit++;

	p8bit +=4;
	p16bit +=4;
	
	int Test = 10;
	
    //while (1) 
    //{
		//
    //}
}

